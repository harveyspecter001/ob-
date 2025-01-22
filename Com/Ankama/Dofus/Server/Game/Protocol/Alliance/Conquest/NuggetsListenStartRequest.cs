using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000DA7 RID: 3495
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NuggetsListenStartRequest : IMessage<NuggetsListenStartRequest>, IMessage, IEquatable<NuggetsListenStartRequest>, IDeepCloneable<NuggetsListenStartRequest>, IBufferMessage
	{
		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x0600A875 RID: 43125 RVA: 0x00295348 File Offset: 0x00293548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NuggetsListenStartRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x0600A876 RID: 43126 RVA: 0x00295358 File Offset: 0x00293558
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

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x0600A877 RID: 43127 RVA: 0x00295368 File Offset: 0x00293568
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

		// Token: 0x0600A878 RID: 43128 RVA: 0x00295378 File Offset: 0x00293578
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsListenStartRequest()
		{
		}

		// Token: 0x0600A879 RID: 43129 RVA: 0x00295388 File Offset: 0x00293588
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsListenStartRequest(NuggetsListenStartRequest other)
		{
		}

		// Token: 0x0600A87A RID: 43130 RVA: 0x00295398 File Offset: 0x00293598
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsListenStartRequest Clone()
		{
			return null;
		}

		// Token: 0x0600A87B RID: 43131 RVA: 0x002953A8 File Offset: 0x002935A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A87C RID: 43132 RVA: 0x002953B8 File Offset: 0x002935B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NuggetsListenStartRequest other)
		{
			return true;
		}

		// Token: 0x0600A87D RID: 43133 RVA: 0x002953C8 File Offset: 0x002935C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A87E RID: 43134 RVA: 0x002953D8 File Offset: 0x002935D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A87F RID: 43135 RVA: 0x002953E8 File Offset: 0x002935E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A880 RID: 43136 RVA: 0x002953F8 File Offset: 0x002935F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A881 RID: 43137 RVA: 0x00295408 File Offset: 0x00293608
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A882 RID: 43138 RVA: 0x00295418 File Offset: 0x00293618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NuggetsListenStartRequest other)
		{
		}

		// Token: 0x0600A883 RID: 43139 RVA: 0x00295428 File Offset: 0x00293628
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A884 RID: 43140 RVA: 0x00295438 File Offset: 0x00293638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A885 RID: 43141 RVA: 0x00295448 File Offset: 0x00293648
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NuggetsListenStartRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					NuggetsListenStartRequest._parser = new MessageParser<NuggetsListenStartRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600A886 RID: 43142 RVA: 0x0029552C File Offset: 0x0029372C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b9Oj8QJl0ZBDRR0UFBeY()
		{
			return true;
		}

		// Token: 0x0600A887 RID: 43143 RVA: 0x00295534 File Offset: 0x00293734
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NuggetsListenStartRequest dCZ2mwJlC8P3houvQdB8()
		{
			return null;
		}

		// Token: 0x04003DFA RID: 15866
		private static readonly MessageParser<NuggetsListenStartRequest> _parser;

		// Token: 0x04003DFB RID: 15867
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DFC RID: 15868
		internal static NuggetsListenStartRequest R71EOtJlVFA9C3R7V5fl;
	}
}
