using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C53 RID: 3155
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SurrenderVoteUpdateEvent : IMessage<SurrenderVoteUpdateEvent>, IMessage, IEquatable<SurrenderVoteUpdateEvent>, IDeepCloneable<SurrenderVoteUpdateEvent>, IBufferMessage
	{
		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06009792 RID: 38802 RVA: 0x002785E0 File Offset: 0x002767E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SurrenderVoteUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06009793 RID: 38803 RVA: 0x002785F0 File Offset: 0x002767F0
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

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06009794 RID: 38804 RVA: 0x00278600 File Offset: 0x00276800
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

		// Token: 0x06009795 RID: 38805 RVA: 0x00278610 File Offset: 0x00276810
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteUpdateEvent()
		{
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x00278620 File Offset: 0x00276820
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteUpdateEvent(SurrenderVoteUpdateEvent other)
		{
		}

		// Token: 0x06009797 RID: 38807 RVA: 0x00278630 File Offset: 0x00276830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x06009798 RID: 38808 RVA: 0x00278640 File Offset: 0x00276840
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009799 RID: 38809 RVA: 0x00278650 File Offset: 0x00276850
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SurrenderVoteUpdateEvent other)
		{
			return true;
		}

		// Token: 0x0600979A RID: 38810 RVA: 0x00278660 File Offset: 0x00276860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600979B RID: 38811 RVA: 0x00278670 File Offset: 0x00276870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600979C RID: 38812 RVA: 0x00278680 File Offset: 0x00276880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600979D RID: 38813 RVA: 0x00278690 File Offset: 0x00276890
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600979E RID: 38814 RVA: 0x002786A0 File Offset: 0x002768A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600979F RID: 38815 RVA: 0x002786B0 File Offset: 0x002768B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SurrenderVoteUpdateEvent other)
		{
		}

		// Token: 0x060097A0 RID: 38816 RVA: 0x002786C0 File Offset: 0x002768C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060097A1 RID: 38817 RVA: 0x002786D0 File Offset: 0x002768D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060097A2 RID: 38818 RVA: 0x002786E0 File Offset: 0x002768E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SurrenderVoteUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					SurrenderVoteUpdateEvent._parser = new MessageParser<SurrenderVoteUpdateEvent>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060097A3 RID: 38819 RVA: 0x002787AC File Offset: 0x002769AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Rsl5snJNABtyHN5ejBhZ()
		{
			return true;
		}

		// Token: 0x060097A4 RID: 38820 RVA: 0x002787B4 File Offset: 0x002769B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SurrenderVoteUpdateEvent cZRHRaJNBE9xrBxK3vu2()
		{
			return null;
		}

		// Token: 0x04003851 RID: 14417
		private static readonly MessageParser<SurrenderVoteUpdateEvent> _parser;

		// Token: 0x04003852 RID: 14418
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003853 RID: 14419
		internal static SurrenderVoteUpdateEvent KLOF5kJNmDrl3j2YfPaf;
	}
}
