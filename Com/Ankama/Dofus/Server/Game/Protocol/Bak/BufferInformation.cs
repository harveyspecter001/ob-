using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BDC RID: 3036
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BufferInformation : IMessage<BufferInformation>, IMessage, IEquatable<BufferInformation>, IDeepCloneable<BufferInformation>, IBufferMessage
	{
		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06009219 RID: 37401 RVA: 0x002714F4 File Offset: 0x0026F6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BufferInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x0600921A RID: 37402 RVA: 0x00271504 File Offset: 0x0026F704
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

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x0600921B RID: 37403 RVA: 0x00271514 File Offset: 0x0026F714
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

		// Token: 0x0600921C RID: 37404 RVA: 0x00271524 File Offset: 0x0026F724
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferInformation()
		{
		}

		// Token: 0x0600921D RID: 37405 RVA: 0x00271534 File Offset: 0x0026F734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferInformation(BufferInformation other)
		{
		}

		// Token: 0x0600921E RID: 37406 RVA: 0x00271544 File Offset: 0x0026F744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferInformation Clone()
		{
			return null;
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x0600921F RID: 37407 RVA: 0x00271554 File Offset: 0x0026F754
		// (set) Token: 0x06009220 RID: 37408 RVA: 0x00271564 File Offset: 0x0026F764
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long BufferId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06009221 RID: 37409 RVA: 0x00271574 File Offset: 0x0026F774
		// (set) Token: 0x06009222 RID: 37410 RVA: 0x00271584 File Offset: 0x0026F784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BufferAmount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009223 RID: 37411 RVA: 0x00271594 File Offset: 0x0026F794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009224 RID: 37412 RVA: 0x002715A4 File Offset: 0x0026F7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BufferInformation other)
		{
			return true;
		}

		// Token: 0x06009225 RID: 37413 RVA: 0x002715B4 File Offset: 0x0026F7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009226 RID: 37414 RVA: 0x002715C4 File Offset: 0x0026F7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009227 RID: 37415 RVA: 0x002715D4 File Offset: 0x0026F7D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009228 RID: 37416 RVA: 0x002715E4 File Offset: 0x0026F7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009229 RID: 37417 RVA: 0x002715F4 File Offset: 0x0026F7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600922A RID: 37418 RVA: 0x00271604 File Offset: 0x0026F804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BufferInformation other)
		{
		}

		// Token: 0x0600922B RID: 37419 RVA: 0x00271614 File Offset: 0x0026F814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600922C RID: 37420 RVA: 0x00271624 File Offset: 0x0026F824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600922D RID: 37421 RVA: 0x00271634 File Offset: 0x0026F834
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BufferInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BufferInformation._parser = new MessageParser<BufferInformation>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600922E RID: 37422 RVA: 0x00271718 File Offset: 0x0026F918
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool koVjdkJEGNM1ShKFWESB()
		{
			return true;
		}

		// Token: 0x0600922F RID: 37423 RVA: 0x00271720 File Offset: 0x0026F920
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BufferInformation trQxSXJEgYmudEZSS3B3()
		{
			return null;
		}

		// Token: 0x0400366B RID: 13931
		private static readonly MessageParser<BufferInformation> _parser;

		// Token: 0x0400366C RID: 13932
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400366D RID: 13933
		public const int BufferIdFieldNumber = 1;

		// Token: 0x0400366E RID: 13934
		private long bufferId_;

		// Token: 0x0400366F RID: 13935
		public const int BufferAmountFieldNumber = 2;

		// Token: 0x04003670 RID: 13936
		private long bufferAmount_;

		// Token: 0x04003671 RID: 13937
		internal static BufferInformation pFLrZfJEJxFya3MVAjBl;
	}
}
