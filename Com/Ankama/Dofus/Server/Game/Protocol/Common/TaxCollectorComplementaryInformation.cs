using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B91 RID: 2961
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorComplementaryInformation : IMessage<TaxCollectorComplementaryInformation>, IMessage, IEquatable<TaxCollectorComplementaryInformation>, IDeepCloneable<TaxCollectorComplementaryInformation>, IBufferMessage
	{
		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06008E37 RID: 36407 RVA: 0x0026B6DC File Offset: 0x002698DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorComplementaryInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06008E38 RID: 36408 RVA: 0x0026B6EC File Offset: 0x002698EC
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

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x06008E39 RID: 36409 RVA: 0x0026B6FC File Offset: 0x002698FC
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

		// Token: 0x06008E3A RID: 36410 RVA: 0x0026B70C File Offset: 0x0026990C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorComplementaryInformation()
		{
		}

		// Token: 0x06008E3B RID: 36411 RVA: 0x0026B71C File Offset: 0x0026991C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorComplementaryInformation(TaxCollectorComplementaryInformation other)
		{
		}

		// Token: 0x06008E3C RID: 36412 RVA: 0x0026B72C File Offset: 0x0026992C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorComplementaryInformation Clone()
		{
			return null;
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x06008E3D RID: 36413 RVA: 0x0026B73C File Offset: 0x0026993C
		// (set) Token: 0x06008E3E RID: 36414 RVA: 0x0026B74C File Offset: 0x0026994C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaxCollectorLootInformation LootInformation
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

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x06008E3F RID: 36415 RVA: 0x0026B75C File Offset: 0x0026995C
		// (set) Token: 0x06008E40 RID: 36416 RVA: 0x0026B76C File Offset: 0x0026996C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaxCollectorWaitingForHelpInformation WaitingForHelpInformation
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

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x06008E41 RID: 36417 RVA: 0x0026B77C File Offset: 0x0026997C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TaxCollectorComplementaryInformation.ComplementaryInformationOneofCase ComplementaryInformationCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TaxCollectorComplementaryInformation.ComplementaryInformationOneofCase)null;
			}
		}

		// Token: 0x06008E42 RID: 36418 RVA: 0x0026B790 File Offset: 0x00269990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearComplementaryInformation()
		{
		}

		// Token: 0x06008E43 RID: 36419 RVA: 0x0026B7A0 File Offset: 0x002699A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008E44 RID: 36420 RVA: 0x0026B7B0 File Offset: 0x002699B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorComplementaryInformation other)
		{
			return true;
		}

		// Token: 0x06008E45 RID: 36421 RVA: 0x0026B7C0 File Offset: 0x002699C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008E46 RID: 36422 RVA: 0x0026B7D0 File Offset: 0x002699D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008E47 RID: 36423 RVA: 0x0026B7E0 File Offset: 0x002699E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008E48 RID: 36424 RVA: 0x0026B7F0 File Offset: 0x002699F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008E49 RID: 36425 RVA: 0x0026B800 File Offset: 0x00269A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008E4A RID: 36426 RVA: 0x0026B810 File Offset: 0x00269A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorComplementaryInformation other)
		{
		}

		// Token: 0x06008E4B RID: 36427 RVA: 0x0026B820 File Offset: 0x00269A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008E4C RID: 36428 RVA: 0x0026B830 File Offset: 0x00269A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008E4D RID: 36429 RVA: 0x0026B840 File Offset: 0x00269A40
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorComplementaryInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					TaxCollectorComplementaryInformation._parser = new MessageParser<TaxCollectorComplementaryInformation>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06008E4E RID: 36430 RVA: 0x0026B90C File Offset: 0x00269B0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JXgWWAJ9wju6v7vrxDSC()
		{
			return true;
		}

		// Token: 0x06008E4F RID: 36431 RVA: 0x0026B914 File Offset: 0x00269B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorComplementaryInformation EGEbw0J9QmotbZEbsGaD()
		{
			return null;
		}

		// Token: 0x040034CA RID: 13514
		private static readonly MessageParser<TaxCollectorComplementaryInformation> _parser;

		// Token: 0x040034CB RID: 13515
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034CC RID: 13516
		public const int LootInformationFieldNumber = 1;

		// Token: 0x040034CD RID: 13517
		public const int WaitingForHelpInformationFieldNumber = 2;

		// Token: 0x040034CE RID: 13518
		private object complementaryInformation_;

		// Token: 0x040034CF RID: 13519
		private TaxCollectorComplementaryInformation.ComplementaryInformationOneofCase complementaryInformationCase_;

		// Token: 0x040034D0 RID: 13520
		private static TaxCollectorComplementaryInformation Ro7gjeJ9tEL8rdXKQmqN;

		// Token: 0x02000B92 RID: 2962
		public enum ComplementaryInformationOneofCase
		{
			// Token: 0x040034D2 RID: 13522
			None,
			// Token: 0x040034D3 RID: 13523
			LootInformation,
			// Token: 0x040034D4 RID: 13524
			WaitingForHelpInformation
		}
	}
}
