using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D70 RID: 3440
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceMotdSetRequest : IMessage<AllianceMotdSetRequest>, IMessage, IEquatable<AllianceMotdSetRequest>, IDeepCloneable<AllianceMotdSetRequest>, IBufferMessage
	{
		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x0600A5CD RID: 42445 RVA: 0x00291008 File Offset: 0x0028F208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceMotdSetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x0600A5CE RID: 42446 RVA: 0x00291018 File Offset: 0x0028F218
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

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x0600A5CF RID: 42447 RVA: 0x00291028 File Offset: 0x0028F228
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

		// Token: 0x0600A5D0 RID: 42448 RVA: 0x00291038 File Offset: 0x0028F238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMotdSetRequest()
		{
		}

		// Token: 0x0600A5D1 RID: 42449 RVA: 0x00291048 File Offset: 0x0028F248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMotdSetRequest(AllianceMotdSetRequest other)
		{
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x00291058 File Offset: 0x0028F258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMotdSetRequest Clone()
		{
			return null;
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x0600A5D3 RID: 42451 RVA: 0x00291068 File Offset: 0x0028F268
		// (set) Token: 0x0600A5D4 RID: 42452 RVA: 0x00291078 File Offset: 0x0028F278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x00291088 File Offset: 0x0028F288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A5D6 RID: 42454 RVA: 0x00291098 File Offset: 0x0028F298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceMotdSetRequest other)
		{
			return true;
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x002910A8 File Offset: 0x0028F2A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x002910B8 File Offset: 0x0028F2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x002910C8 File Offset: 0x0028F2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A5DA RID: 42458 RVA: 0x002910D8 File Offset: 0x0028F2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A5DB RID: 42459 RVA: 0x002910E8 File Offset: 0x0028F2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x002910F8 File Offset: 0x0028F2F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceMotdSetRequest other)
		{
		}

		// Token: 0x0600A5DD RID: 42461 RVA: 0x00291108 File Offset: 0x0028F308
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A5DE RID: 42462 RVA: 0x00291118 File Offset: 0x0028F318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x00291128 File Offset: 0x0028F328
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceMotdSetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AllianceMotdSetRequest._parser = new MessageParser<AllianceMotdSetRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600A5E0 RID: 42464 RVA: 0x0029120C File Offset: 0x0028F40C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yF1e93Jky3l6ndS0EjKN()
		{
			return true;
		}

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x00291214 File Offset: 0x0028F414
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceMotdSetRequest aJoj8JJk65Kqm7gMyFu3()
		{
			return null;
		}

		// Token: 0x04003D24 RID: 15652
		private static readonly MessageParser<AllianceMotdSetRequest> _parser;

		// Token: 0x04003D25 RID: 15653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D26 RID: 15654
		public const int ContentFieldNumber = 1;

		// Token: 0x04003D27 RID: 15655
		private string content_;

		// Token: 0x04003D28 RID: 15656
		internal static AllianceMotdSetRequest geFJY2Jk56BQZpr4K2po;
	}
}
