using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D76 RID: 3446
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceBulletinSetRequest : IMessage<AllianceBulletinSetRequest>, IMessage, IEquatable<AllianceBulletinSetRequest>, IDeepCloneable<AllianceBulletinSetRequest>, IBufferMessage
	{
		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x0600A61B RID: 42523 RVA: 0x00291648 File Offset: 0x0028F848
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceBulletinSetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x0600A61C RID: 42524 RVA: 0x00291658 File Offset: 0x0028F858
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x0600A61D RID: 42525 RVA: 0x00291668 File Offset: 0x0028F868
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x00291678 File Offset: 0x0028F878
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceBulletinSetRequest()
		{
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x00291688 File Offset: 0x0028F888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceBulletinSetRequest(AllianceBulletinSetRequest other)
		{
		}

		// Token: 0x0600A620 RID: 42528 RVA: 0x00291698 File Offset: 0x0028F898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceBulletinSetRequest Clone()
		{
			return null;
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x0600A621 RID: 42529 RVA: 0x002916A8 File Offset: 0x0028F8A8
		// (set) Token: 0x0600A622 RID: 42530 RVA: 0x002916B8 File Offset: 0x0028F8B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Content
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600A623 RID: 42531 RVA: 0x002916C8 File Offset: 0x0028F8C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A624 RID: 42532 RVA: 0x002916D8 File Offset: 0x0028F8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceBulletinSetRequest other)
		{
			return true;
		}

		// Token: 0x0600A625 RID: 42533 RVA: 0x002916E8 File Offset: 0x0028F8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A626 RID: 42534 RVA: 0x002916F8 File Offset: 0x0028F8F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A627 RID: 42535 RVA: 0x00291708 File Offset: 0x0028F908
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A628 RID: 42536 RVA: 0x00291718 File Offset: 0x0028F918
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A629 RID: 42537 RVA: 0x00291728 File Offset: 0x0028F928
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x00291738 File Offset: 0x0028F938
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceBulletinSetRequest other)
		{
		}

		// Token: 0x0600A62B RID: 42539 RVA: 0x00291748 File Offset: 0x0028F948
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A62C RID: 42540 RVA: 0x00291758 File Offset: 0x0028F958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A62D RID: 42541 RVA: 0x00291768 File Offset: 0x0028F968
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceBulletinSetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					AllianceBulletinSetRequest._parser = new MessageParser<AllianceBulletinSetRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A62E RID: 42542 RVA: 0x00291834 File Offset: 0x0028FA34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d8NG4yJkDn0mEWIcyAja()
		{
			return true;
		}

		// Token: 0x0600A62F RID: 42543 RVA: 0x0029183C File Offset: 0x0028FA3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceBulletinSetRequest nT0YavJktn9IlfMeNBIv()
		{
			return null;
		}

		// Token: 0x04003D39 RID: 15673
		private static readonly MessageParser<AllianceBulletinSetRequest> _parser;

		// Token: 0x04003D3A RID: 15674
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D3B RID: 15675
		public const int ContentFieldNumber = 1;

		// Token: 0x04003D3C RID: 15676
		private string content_;

		// Token: 0x04003D3D RID: 15677
		internal static AllianceBulletinSetRequest sEoVayJkCFfecAJe69iS;
	}
}
