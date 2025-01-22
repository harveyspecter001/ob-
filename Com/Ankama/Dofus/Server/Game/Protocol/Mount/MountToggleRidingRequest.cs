using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x0200035F RID: 863
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountToggleRidingRequest : IMessage<MountToggleRidingRequest>, IMessage, IEquatable<MountToggleRidingRequest>, IDeepCloneable<MountToggleRidingRequest>, IBufferMessage
	{
		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x001C690C File Offset: 0x001C4B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountToggleRidingRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x001C691C File Offset: 0x001C4B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x001C692C File Offset: 0x001C4B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x001C693C File Offset: 0x001C4B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountToggleRidingRequest()
		{
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x001C694C File Offset: 0x001C4B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountToggleRidingRequest(MountToggleRidingRequest other)
		{
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x001C695C File Offset: 0x001C4B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountToggleRidingRequest Clone()
		{
			return null;
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x001C696C File Offset: 0x001C4B6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x001C697C File Offset: 0x001C4B7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountToggleRidingRequest other)
		{
			return true;
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x001C698C File Offset: 0x001C4B8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x001C699C File Offset: 0x001C4B9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x001C69AC File Offset: 0x001C4BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x001C69BC File Offset: 0x001C4BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x001C69CC File Offset: 0x001C4BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x001C69DC File Offset: 0x001C4BDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountToggleRidingRequest other)
		{
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x001C69EC File Offset: 0x001C4BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x001C69FC File Offset: 0x001C4BFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x001C6A0C File Offset: 0x001C4C0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountToggleRidingRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					MountToggleRidingRequest._parser = new MessageParser<MountToggleRidingRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x001C6AF0 File Offset: 0x001C4CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ey5qnpOhw1mfRDWCZpgU()
		{
			return true;
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x001C6AF8 File Offset: 0x001C4CF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountToggleRidingRequest OXTrf9OhQo37sE4un8ap()
		{
			return null;
		}

		// Token: 0x04000E62 RID: 3682
		private static readonly MessageParser<MountToggleRidingRequest> _parser;

		// Token: 0x04000E63 RID: 3683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E64 RID: 3684
		private static MountToggleRidingRequest hVlEMbOht7sj8ZcMGGkU;
	}
}
