using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debug
{
	// Token: 0x020007F3 RID: 2035
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DebugInClientEvent : IMessage<DebugInClientEvent>, IMessage, IEquatable<DebugInClientEvent>, IDeepCloneable<DebugInClientEvent>, IBufferMessage
	{
		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x0600635B RID: 25435 RVA: 0x002247E8 File Offset: 0x002229E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DebugInClientEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x0600635C RID: 25436 RVA: 0x002247F8 File Offset: 0x002229F8
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

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x0600635D RID: 25437 RVA: 0x00224808 File Offset: 0x00222A08
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

		// Token: 0x0600635E RID: 25438 RVA: 0x00224818 File Offset: 0x00222A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugInClientEvent()
		{
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x00224828 File Offset: 0x00222A28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugInClientEvent(DebugInClientEvent other)
		{
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x00224838 File Offset: 0x00222A38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugInClientEvent Clone()
		{
			return null;
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06006361 RID: 25441 RVA: 0x00224848 File Offset: 0x00222A48
		// (set) Token: 0x06006362 RID: 25442 RVA: 0x0022485C File Offset: 0x00222A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DebugInClientEvent.Types.DebugLevel Level
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DebugInClientEvent.Types.DebugLevel)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06006363 RID: 25443 RVA: 0x0022486C File Offset: 0x00222A6C
		// (set) Token: 0x06006364 RID: 25444 RVA: 0x0022487C File Offset: 0x00222A7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Message
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

		// Token: 0x06006365 RID: 25445 RVA: 0x0022488C File Offset: 0x00222A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x0022489C File Offset: 0x00222A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DebugInClientEvent other)
		{
			return true;
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x002248AC File Offset: 0x00222AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006368 RID: 25448 RVA: 0x002248BC File Offset: 0x00222ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006369 RID: 25449 RVA: 0x002248CC File Offset: 0x00222ACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600636A RID: 25450 RVA: 0x002248DC File Offset: 0x00222ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600636B RID: 25451 RVA: 0x002248EC File Offset: 0x00222AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600636C RID: 25452 RVA: 0x002248FC File Offset: 0x00222AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DebugInClientEvent other)
		{
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x0022490C File Offset: 0x00222B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x0022491C File Offset: 0x00222B1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x0022492C File Offset: 0x00222B2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DebugInClientEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				DebugInClientEvent._parser = new MessageParser<DebugInClientEvent>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x00224A24 File Offset: 0x00222C24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool huuC41OzgBhMkogpapAK()
		{
			return true;
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x00224A2C File Offset: 0x00222C2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DebugInClientEvent h9d3UsOzsLnYyddjUInM()
		{
			return null;
		}

		// Token: 0x040022E6 RID: 8934
		private static readonly MessageParser<DebugInClientEvent> _parser;

		// Token: 0x040022E7 RID: 8935
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022E8 RID: 8936
		public const int LevelFieldNumber = 1;

		// Token: 0x040022E9 RID: 8937
		private DebugInClientEvent.Types.DebugLevel level_;

		// Token: 0x040022EA RID: 8938
		public const int MessageFieldNumber = 2;

		// Token: 0x040022EB RID: 8939
		private string message_;

		// Token: 0x040022EC RID: 8940
		private static DebugInClientEvent ALxRgyOzG6fHDpUeD74M;

		// Token: 0x020007F4 RID: 2036
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06006372 RID: 25458 RVA: 0x002D4368 File Offset: 0x002D2568
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020007F5 RID: 2037
			public enum DebugLevel
			{
				// Token: 0x040022EE RID: 8942
				[OriginalName("TRACE")]
				Trace,
				// Token: 0x040022EF RID: 8943
				[OriginalName("DEBUG")]
				Debug,
				// Token: 0x040022F0 RID: 8944
				[OriginalName("INFO")]
				Info,
				// Token: 0x040022F1 RID: 8945
				[OriginalName("WARN")]
				Warn,
				// Token: 0x040022F2 RID: 8946
				[OriginalName("ERROR")]
				Error,
				// Token: 0x040022F3 RID: 8947
				[OriginalName("FATAL")]
				Fatal
			}
		}
	}
}
